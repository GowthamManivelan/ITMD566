/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package itmd_566_project1_assignment;

/**
 *
 * @author user
 */
public class PeopleScanner {

	/**
	 * org.w3c.dom.Document document
	 */
	org.w3c.dom.Document document;

	/**
	 * Create new PeopleScanner with org.w3c.dom.Document.
	 */
	public PeopleScanner(org.w3c.dom.Document document) {
		this.document = document;
	}

	/**
	 * Scan through org.w3c.dom.Document document.
	 */
	public void visitDocument() {
		org.w3c.dom.Element element = document.getDocumentElement();
		if ((element != null) && element.getTagName().equals("people")) {
			visitElement_people(element);
		}
		if ((element != null) && element.getTagName().equals("person")) {
			visitElement_person(element);
		}
		if ((element != null) && element.getTagName().equals("firstname")) {
			visitElement_firstname(element);
		}
		if ((element != null) && element.getTagName().equals("lastname")) {
			visitElement_lastname(element);
		}
	}

	/**
	 * Scan through org.w3c.dom.Element named people.
	 */
	void visitElement_people(org.w3c.dom.Element element) {
		// <people>
		// element.getValue();
		org.w3c.dom.NodeList nodes = element.getChildNodes();
		for (int i = 0; i < nodes.getLength(); i++) {
			org.w3c.dom.Node node = nodes.item(i);
			switch (node.getNodeType()) {
			case org.w3c.dom.Node.CDATA_SECTION_NODE:
				// ((org.w3c.dom.CDATASection)node).getData();
				break;
			case org.w3c.dom.Node.ELEMENT_NODE:
				org.w3c.dom.Element nodeElement = (org.w3c.dom.Element) node;
				if (nodeElement.getTagName().equals("person")) {
					visitElement_person(nodeElement);
				}
				break;
			case org.w3c.dom.Node.PROCESSING_INSTRUCTION_NODE:
				// ((org.w3c.dom.ProcessingInstruction)node).getTarget();
				// ((org.w3c.dom.ProcessingInstruction)node).getData();
				break;
			}
		}
	}

	/**
	 * Scan through org.w3c.dom.Element named person.
	 */
	void visitElement_person(org.w3c.dom.Element element) {
		// <person>
		// element.getValue();
		org.w3c.dom.NamedNodeMap attrs = element.getAttributes();
		for (int i = 0; i < attrs.getLength(); i++) {
			org.w3c.dom.Attr attr = (org.w3c.dom.Attr) attrs.item(i);
			if (attr.getName().equals("id")) {
				// <person id="???">
				// attr.getValue();
			}
		}
		org.w3c.dom.NodeList nodes = element.getChildNodes();
		for (int i = 0; i < nodes.getLength(); i++) {
			org.w3c.dom.Node node = nodes.item(i);
			switch (node.getNodeType()) {
			case org.w3c.dom.Node.CDATA_SECTION_NODE:
				// ((org.w3c.dom.CDATASection)node).getData();
				break;
			case org.w3c.dom.Node.ELEMENT_NODE:
				org.w3c.dom.Element nodeElement = (org.w3c.dom.Element) node;
				if (nodeElement.getTagName().equals("firstname")) {
					visitElement_firstname(nodeElement);
				}
				if (nodeElement.getTagName().equals("lastname")) {
					visitElement_lastname(nodeElement);
				}
				break;
			case org.w3c.dom.Node.PROCESSING_INSTRUCTION_NODE:
				// ((org.w3c.dom.ProcessingInstruction)node).getTarget();
				// ((org.w3c.dom.ProcessingInstruction)node).getData();
				break;
			}
		}
	}

	/**
	 * Scan through org.w3c.dom.Element named firstname.
	 */
	void visitElement_firstname(org.w3c.dom.Element element) {
		// <firstname>
		// element.getValue();
		org.w3c.dom.NodeList nodes = element.getChildNodes();
		for (int i = 0; i < nodes.getLength(); i++) {
			org.w3c.dom.Node node = nodes.item(i);
			switch (node.getNodeType()) {
			case org.w3c.dom.Node.CDATA_SECTION_NODE:
				// ((org.w3c.dom.CDATASection)node).getData();
				break;
			case org.w3c.dom.Node.ELEMENT_NODE:
				org.w3c.dom.Element nodeElement = (org.w3c.dom.Element) node;
				break;
			case org.w3c.dom.Node.PROCESSING_INSTRUCTION_NODE:
				// ((org.w3c.dom.ProcessingInstruction)node).getTarget();
				// ((org.w3c.dom.ProcessingInstruction)node).getData();
				break;
			case org.w3c.dom.Node.TEXT_NODE:
				// ((org.w3c.dom.Text)node).getData();
				break;
			}
		}
	}

	/**
	 * Scan through org.w3c.dom.Element named lastname.
	 */
	void visitElement_lastname(org.w3c.dom.Element element) {
		// <lastname>
		// element.getValue();
		org.w3c.dom.NodeList nodes = element.getChildNodes();
		for (int i = 0; i < nodes.getLength(); i++) {
			org.w3c.dom.Node node = nodes.item(i);
			switch (node.getNodeType()) {
			case org.w3c.dom.Node.CDATA_SECTION_NODE:
				// ((org.w3c.dom.CDATASection)node).getData();
				break;
			case org.w3c.dom.Node.ELEMENT_NODE:
				org.w3c.dom.Element nodeElement = (org.w3c.dom.Element) node;
				break;
			case org.w3c.dom.Node.PROCESSING_INSTRUCTION_NODE:
				// ((org.w3c.dom.ProcessingInstruction)node).getTarget();
				// ((org.w3c.dom.ProcessingInstruction)node).getData();
				break;
			case org.w3c.dom.Node.TEXT_NODE:
				// ((org.w3c.dom.Text)node).getData();
				break;
			}
		}
	}

}
