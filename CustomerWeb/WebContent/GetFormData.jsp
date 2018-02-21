<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<style type="text/css">
.tbl_bg {
	background-color: #D7D7D7;
	border: 1px solid #898989;
}

.alt {
	background-color: #EBEBEB;
}

.altalt {
	background-color: #EBEBEB;
	border-bottom: 1px solid #898989;
}

.tbl_bg p {
	font-size: 0.8em;
	text-align: left;
	margin: 0;
	padding: 5px;
	font-family: Arial, Helvetica, sans-serif;
}

.lft_bdr {
	border-left: 1px solid #898989;
}

.input {
	width: 300px;
	border: 1px solid #ACACAC;
	margin: 0;
	padding: 2px;
}

textarea {
	width: 300px;
	height: 100px;
	border: 1px solid #ACACAC;
}
</style>
<script src="ValidateForm.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Hello World Java EE</title>
</head>
<body>
	<h1>Customer Form</h1>
	<form name="customer" action="customerServlet" method="post"
		onsubmit="return validateForm()">

		<tr>
			<td colspan="2" valign="top" class="altalt"><p>
					Customer Name:<input type="text" name="yourName" size="20">
				</p></td>
			<td width="150" valign="top"><p>
					SSN Number: <input type="text" name="yourSSN" size="20">
				</p></td>
			<td valign="top" class="alt"><p>
					ZIP Code: <input type="text" name="yourZip" size="20">
				</p></td>
			<td colspan="2" valign="top" class="altalt"><p>
					Email: <input type="text" name="yourEmail" size="20">
				</p></td>
			<td colspan="2" valign="top" class="altalt"><p>
					Address:<input type="text" name="yourAddress" size="20">
				</p></td>
			<td colspan="2" valign="top" class="altalt"><p>
					City: <input type="text" name="yourCity" size="20">
				</p></td>
			<td colspan="2" valign="top" class="altalt"><p>
					State: <select name="yourState">
						<option>AL</option>
						<option>AK</option>
						<option>AZ</option>
						<option>IL</option>
					</select>
				</p></td>
			<input type="submit" value="Submit" />
			<p>Message: ${message}</p>
		</tr>
	</form>
</body>
</html>