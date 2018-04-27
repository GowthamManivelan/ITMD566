/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.LocationList;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Location;

/**
 *
 */
@WebService(name = "LocationList", serviceName = "LocationListService")
public class LocationListService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listLocations")
    public ArrayList<Location> listLocations (@WebParam(name = "locationCode") String locationCode) throws Exception{
        
        LocationList ll = new LocationList();
        return ll.getLocations(locationCode);
    }
}
