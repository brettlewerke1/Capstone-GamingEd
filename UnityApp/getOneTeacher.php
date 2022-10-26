<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');

    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }



    $role = "admin";



    $username = $_POST["Username"];

    // SQL query for specific teacher
    $queryString = "SELECT Account.*  FROM RTX.Account WHERE Account_Username='".$username."' AND Account_Role = '".$role."';";

    $teachers = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teachers);

    // fetching variables from database
    $returnedUsername = $userInfo["Account_Username"];
    $className = $userInfo["Course_Tag"];


    


    // printing variables receieved from database
    echo($role." ".$returnedUsername." ".$className);

?>
