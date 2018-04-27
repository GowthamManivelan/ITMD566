/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.OrderList;
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import model.Order;


@WebService(name = "OrderList", serviceName = "OrderListService")
public class OrderListService {

    
    @WebMethod(operationName = "listOrders")
    public ArrayList<Order> listOrders(@WebParam(name = "isSpecial") String isSpecial) throws Exception {

        OrderList ol = new OrderList();
        System.out.println(ol.getOrders(isSpecial));
        return ol.getOrders(isSpecial);
    }

}


