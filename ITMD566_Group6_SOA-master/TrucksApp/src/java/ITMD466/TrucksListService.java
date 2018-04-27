/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;
import controllers.TruckList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.util.ArrayList;
import model.Truck;

/**
 *
 * @author Shabarish
 */
@WebService(serviceName = "TrucksList")
public class TrucksListService {

    /**
     * This is a sample web service operation
     * @param employeeID
     * @return 
     * @throws java.lang.Exception 
     */
    @WebMethod(operationName = "listTrucks")
    public ArrayList<Truck> listTrucks(@WebParam(name = "employeeID") String employeeID) throws Exception {

        TruckList tl = new TruckList();
        System.out.println(tl.getTrucks(employeeID));
        return tl.getTrucks(employeeID);
    }
}
