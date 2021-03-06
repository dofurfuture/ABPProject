﻿(function () {
    $(function () {
        var app = new Vue({
            el: '#vue-app',
            data: {
                formItem: {},
                abpService: abp.services.app.user,
                abpRoleService: abp.services.app.role,
                deleteId: null,
                allRoles: [],
                selectedRoles: [],
                setRoleUserId: null
            },
            //生命周期钩子（vue替换dom完成之后执行）
            mounted: function () {
                this.init()
            },
            methods: {
                //初始化表格数据
                initTableData: function(params) {
                    var that = this;
                    initTable({
                        //表格
                        table: $('#table-data'),
                        //批量删除按钮
                        remove: $('#table-remove'),
                        //批量删除弹窗确认按钮
                        delConfirmed: $('#deleleAll-confirmed'),
                        columns: [
                                {
                                field: 'selectState',
                                    checkbox: true,
                                    align: 'center',
                                    valign: 'middle'
                                },
                                {
                                    field: 'userName',
                                    title: '用户名',
                                    sortable: true,
                                    align: 'center'
                                },
                                {
                                    field: 'name',
                                    title: '名字',
                                    sortable: true,
                                    align: 'center'
                                },
                                {
                                    field: 'emailAddress',
                                    title: '邮箱',
                                    align: 'center'
                                },
                                {
                                    field: 'isActive',
                                    title: '是否激活',
                                    align: 'center'
                                },
                                {
                                    field: 'option',
                                    title: '操作',
                                    align: 'center',
                                    events: params.operateEvents,
                                    formatter: function (value, row, index) {
                                        return [
                                            '<button type="button" class="btn btn-orange btn-xs role-item table-btn">角色</button>',
                                            '<button type="button" class="btn btn-green btn-xs permission-item table-btn">权限</button>',
                                            '<button type="button" data-toggle="modal" data-target="#del-confirm" class="btn btn-danger btn-xs remove-item table-btn">删除</button>'
                                        ].join('');
                                    }
                                }
                        ],
                        delete: params.deleteItem
                    });
                },

                //初始化页面
                init: function() {
                    var that = this;
                    //按钮事件
                    var operateEvents = {
                        'click .role-item': function (e, value, row, index) {
                            var id = row.id;
                            that.setRoles(id);
                        },
                        'click .remove-item': function (e, value, row, index) {
                            that.deleteId = [row.id]
                        }
                    }
                    that.initTableData({
                        operateEvents: operateEvents,
                        deleteItem: that.deleteItem
                    });
                },

                //根据id获取详情
                getUserById: function(id) {
                    var that = this
                    var postData = { "id": id }
                    abp.ui.setBusy($("#vue-app"));
                    this.abpService.getUserById(postData).done(function (res) {
                        that.formItem = res;
                    }).always(function () {
                        abp.ui.clearBusy($("#vue-app"));
                    });
                },

                //删除一到多项
                deleteItem: function(params) {
                    var that = this
                    var postData = { "ids": params.ids }
                    abp.ui.setBusy($("#vue-app"));
                    that.abpService.deleteUser(postData).done(function (res) {
                        params.callBack()
                    }).always(function () {
                        abp.ui.clearBusy($("#vue-app"));
                        $(".del-confirm").modal('hide');
                    });
                },
                delConfirmed: function() {
                    var that = this;
                    that.deleteItem(
                        {
                            ids: that.deleteId,
                            callBack: function () {
                                g_table.bootstrapTable('remove', {
                                    field: 'id',
                                    values: that.deleteId
                                });
                            }
                        }
                    )
                },

                //创建角色
                createItem: function() {
                    this.formItem = {};
                    $("#tab-edit a:first").trigger("click");
                },
                subFormData: function(e) {
                    e.preventDefault();
                    var _$form = $("#editItemForm");
                    _$form.validate();
                    if (!_$form.valid()) {
                        return;
                    }
                    var postData = this.formItem;
                    abp.ui.setBusy($("#vue-app"));
                    this.abpService.createUser(postData).done(function () {
                        location.reload(true);
                    }).always(function () {
                        abp.ui.clearBusy($("#vue-app"));
                    });
                },
                submitCancel: function(e) {
                    submitCancel(e.target);
                    if ($(e.target).attr("target") == "tab-edit") {
                        this.formItem = {};
                    }
                },

                //角色分配
                setRoles: function(id) {
                    var that = this;
                    $("#tab-roles").css("display", "").find("a:first").trigger("click");
                    that.setRoleUserId = id;
                    that.getRolesByUser(id)
                },
                getRolesByUser: function(id) {
                    var that = this
                    var postData = { "id": id }
                    abp.ui.setBusy($("#vue-app"));
                    this.abpRoleService.getRolesByUser(postData).done(function (res) {
                        that.allRoles = res.allRoles;
                        that.selectedRoles = res.inRoles
                    }).always(function () {
                        abp.ui.clearBusy($("#vue-app"));
                    });
                },
                subSetRoles: function() {
                    var that = this
                    var postData = { "key": that.setRoleUserId, "values": that.selectedRoles }
                    abp.ui.setBusy($("#vue-app"));
                    this.abpService.addToRoles(postData).done(function () {
                        that.setRoleUserId = null
                        submitCancel();
                    }).always(function () {
                        abp.ui.clearBusy($("#vue-app"));
                    });
                }
            }
        })
    })
})();