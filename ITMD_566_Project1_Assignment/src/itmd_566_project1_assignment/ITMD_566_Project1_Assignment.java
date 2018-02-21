/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package itmd_566_project1_assignment;

import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;
import java.sql.*;

/**
 *
 * @author Jenny Feng
 */
public class ITMD_566_Project1_Assignment {



	public static void main(String[] args) {

		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
		DBconnect db = new DBconnect();

		try {

			DocumentBuilder builder = factory.newDocumentBuilder();
			Document doc = builder.parse("src/itmd_566_project1_assignment/people.xml");
			NodeList personList = doc.getElementsByTagName("person");
			for(int i=0;i<personList.getLength();i++ ){
				Node p = personList.item(i);
				if(p.getNodeType()==Node.ELEMENT_NODE){
					Element person = (Element) p;
					String id = person.getAttribute("id");
					String firstname = person.getAttribute("firstname");
					String lastname = person.getAttribute("lastname");
					NodeList nameList =person.getChildNodes();
					for(int j=0;j<nameList.getLength();j++){
						Node n = nameList.item(j);
						if(n.getNodeType()==Node.ELEMENT_NODE){

							Element name = (Element) n;
							System.out.println("Person" + id + ":"+name.getTagName()
							+ "=" + name.getTextContent());
							if(name.getTagName().equalsIgnoreCase("firstname")){
								//System.out.println("firstName: " + name.getTextContent());
								firstname =name.getTextContent();

							}
							if(name.getTagName().equalsIgnoreCase("lastname")){
								// System.out.println("lastName: " + name.getTextContent());
								lastname = name.getTextContent();
							}
							System.out.println(" "+firstname + " " + lastname );
							db.setPerson(id, firstname, lastname);

						}
					}
				}
			}


		} catch (ParserConfigurationException ex) {
			Logger.getLogger(ITMD_566_Project1_Assignment.class.getName()).log(Level.SEVERE, null, ex);
		} catch (SAXException ex) {
			Logger.getLogger(ITMD_566_Project1_Assignment.class.getName()).log(Level.SEVERE, null, ex);
		} catch (IOException ex) {
			Logger.getLogger(ITMD_566_Project1_Assignment.class.getName()).log(Level.SEVERE, null, ex);
		}
	}


}
