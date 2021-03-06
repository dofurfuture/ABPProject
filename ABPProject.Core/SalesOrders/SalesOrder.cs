﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABPProject.SalesOrders
{
    [Table("SalesOrder")]
    public class SalesOrder : Entity, IMayHaveTenant, IMayHaveOrganizationUnit, IHasCreationTime, ICreationAudited, ISoftDelete, IModificationAudited
    {
        public virtual int? TenantId { get; set; }
        public virtual long? OrganizationUnitId { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual long? LastModifierUserId { get; set; }




        /// <summary>
        /// 销售订单编号
        /// </summary>
        public virtual string SalesNum { get; set; }
        /// <summary>
        /// 客户编号
        /// </summary>
        public virtual int ClientId { get; set; }
        /// <summary>
        /// 产品站点
        /// </summary>
        public virtual int InventSiteId { get; set; }
        /// <summary>
        /// 站点仓库
        /// </summary>
        public virtual int InventLocationId { get; set; }
        /// <summary>
        /// 销售合同Id
        /// </summary>
        public virtual int SalesContractId { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public virtual string Consignee { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public virtual string DeliveryAddress { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public virtual string PostCode { get; set; }
        /// <summary>
        /// 配送方式
        /// </summary>
        public virtual string DistributionMode { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public virtual string InvoiceHeader { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public virtual string Instructions { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public virtual string PaymentMethod { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public virtual int State { get; set; }

        /// <summary>
        /// 订单行
        /// </summary>
        public virtual ICollection<SalesOrderItem> SalesOrderItem { get; set; }
    }
}
