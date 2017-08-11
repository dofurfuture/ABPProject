﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPProject.SalesOrders.Dto
{
    [AutoMap(typeof(SalesOrderItem))]
    public class EditSalesOrderItemDto
    {
        public int? Id { get; set; }
        public virtual int SalesOrderId { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public virtual string InventId { get; set; }
        /// <summary>
        /// 产品批次
        /// </summary>
        public virtual string InventBatch { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public virtual int PurchCount { get; set; }
        /// <summary>
        /// 产品单价
        /// </summary>
        public virtual int PurchPrice { get; set; }
    }
}
