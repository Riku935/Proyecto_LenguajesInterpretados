<?php
$servername = "localhost";
$username = "root";
$password = "1234";
$dbname = "ProyectoAstronauta";

$p1 = $_REQUEST["user"];
$p2 = $_REQUEST["password"];

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "INSERT INTO users (username, passwordd) VALUES
( '".$p1."', '".$p2."' )";

if ($conn->query($sql) === TRUE) {
  echo "New record created successfully";
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>