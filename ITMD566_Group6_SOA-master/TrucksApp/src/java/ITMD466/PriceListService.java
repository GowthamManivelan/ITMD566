/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.PriceList;
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import model.Price;


@WebService(name = "PriceList", serviceName = "PriceListService")
public class PriceListService {

   
    @WebMethod(operationName = "listPrices")
    public ArrayList<Price> listPrices(@WebParam(name = "priceID") String priceID) throws Exception {

        PriceList pl = new PriceList();
        System.out.println(pl.getPrices(priceID));
        return pl.getPrices(priceID);
    }

}
