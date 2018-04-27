/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.ExpenseList;
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import model.Expense;


@WebService(name = "ExpenseList", serviceName = "ExpenseListService")
public class ExpenseListService {

   
    @WebMethod(operationName = "paymentMethod")
    public ArrayList<Expense> listExpenses(@WebParam(name = "paymentMethod") String paymentMethod) throws Exception {

        ExpenseList el = new ExpenseList();
        System.out.println(el.getExpenses(paymentMethod));
        return el.getExpenses(paymentMethod);
    }

}
