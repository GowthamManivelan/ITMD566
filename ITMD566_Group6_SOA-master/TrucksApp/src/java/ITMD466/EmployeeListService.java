/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.EmployeeList;
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import model.Employee;


@WebService(name = "EmployeeList", serviceName = "EmployeeListService")
public class EmployeeListService {

   
    @WebMethod(operationName = "EXT")
    public ArrayList<Employee> listEmployees(@WebParam(name = "extension") String extension) throws Exception {

        EmployeeList el = new EmployeeList();
        System.out.println(el.getEmployees(extension));
        return el.getEmployees(extension);
    }

}
