/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;

import controllers.TransactionList;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Transaction;

/**
 *
 */
@WebService(name = "TransactionList", serviceName = "TransactionListService")
public class TransactionListService {

    /**
     * This is a sample web service operation
     * @param orderID
     * @return 
     * @throws java.lang.Exception 
     */
    @WebMethod(operationName = "listTransactions")
    public ArrayList<Transaction> listTransactions (@WebParam(name = "orderID") String orderID) throws Exception{
        
        TransactionList tl = new TransactionList();
        return tl.getTransaction(orderID);
    }
}
