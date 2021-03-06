﻿using Abp.AutoMapper;

namespace ABPProject.SalesOrders.Dto
{
    [AutoMap(typeof(SalesOrderItem))]
    public class SalesOrderItemListDto
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 产品批次
        /// </summary>
        public int InventBatchId { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int PurchCount { get; set; }
        /// <summary>
        /// 产品单价
        /// </summary>
        public int PurchPrice { get; set; }
    }
}
