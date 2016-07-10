using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

/*
 * 已创建的销售订单（包括已删除的订单）Manager类
 */

namespace ERPApplication
{
    class CreatedOrderManager
    {
        CreatedOrderDao createdOrderDao = new CreatedOrderDao();

        /*
         * 查询活动订单信息
         */
        public DataTable queryActiveSaleOrderInformationByState(String state, bool flag)
        {
            return createdOrderDao.queryActiveSaleOrderInformationByState(state, flag);
        }

        /*
         * 查询删除订单信息
         */
        public DataTable queryRemovedSaleOrderInformation()
        {
            return createdOrderDao.queryRemovedSaleOrderInformation();
        }

        /*
         * 删除一个订单
         */
        public void removeSaleOrderByOrderNo(String saleNo)
        {
            //将待删除订单信息插入“删除表”
            createdOrderDao.addSaleOrderItem(saleNo);
            //从原表删除该订单信息
            createdOrderDao.removeSaleOrderByOrderNo(saleNo);

        }
    }
}
