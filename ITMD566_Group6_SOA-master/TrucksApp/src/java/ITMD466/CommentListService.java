

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ITMD466;


import controllers.CommentList;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Comment;




@WebService(name = "CommentList", serviceName = "CommentListService")
public class CommentListService {

   
    @WebMethod(operationName = "TransactionID")
    public ArrayList<Comment> listComments(@WebParam(name = "transactionID") String transactionID) throws Exception {

        CommentList cml = new CommentList();
        System.out.println(cml.getComments(transactionID));
        return cml.getComments(transactionID);
    }

}

