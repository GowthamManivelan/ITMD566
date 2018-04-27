/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;



import controllers.ItemList;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Item;




@WebService(name = "ItemList", serviceName = "ItemListService")
public class ItemListService {

   
    @WebMethod(operationName = "ItemID")
    public ArrayList<Item> listItems(@WebParam(name = "itemID") String itemID) throws Exception {

        ItemList itm = new ItemList();
         
          System.out.println(itm.getItems(itemID));
        return itm.getItems(itemID);
    }

}

