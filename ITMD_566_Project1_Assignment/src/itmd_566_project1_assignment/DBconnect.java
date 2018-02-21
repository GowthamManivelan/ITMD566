/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package itmd_566_project1_assignment;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

/**
 *
 * @author Jenny Feng
 */
public class DBconnect {
	PreparedStatement insertJFGROUP6 = null;
	Connection connect = null;

	public static void connection(){
		try{
			Class.forName("oracle.jdbc.driver.OracleDriver");
		}catch (ClassNotFoundException ce){
		}
	}
	public DBconnect(){
		connection();
		int result =0;
		String host = "jdbc:oracle:thin:@www.papademas.net:1521:orcl";
		String user = "ora_jfeng8";
		String pass = "oracle";

		try{
			connect = DriverManager.getConnection(host, user, pass); 
			insertJFGROUP6 = connect.prepareStatement("INSERT INTO JFGROUP6 (PERSONID, FIRSTNAME, LASTNAME) VALUES (?, ?, ?)");

		}
		catch (SQLException e){
		}
	}
	public int setPerson(String personID, String firstName, String lastName){
		int result = 0;
		try{
			insertJFGROUP6.setString (1, personID);
			insertJFGROUP6.setString(2,firstName);
			insertJFGROUP6.setString(3,lastName);
			result =insertJFGROUP6.executeUpdate();
		}
		catch (SQLException se){
			se.getStackTrace();;
		}
		return result;
	}
}




