<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'account');

    //check for connection success
    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }

    $username = $_POST["Username"];

    $password = $_POST["Password"];

    $firstname =  $_POST["Firstname"];

    $lastname =  $_POST["Lastname"];

    $admin = "admin";

    //if name already exists
    $nameCheckString = "SELECT * FROM account.people WHERE Username='".$username."';";


    $nameCheck = mysqli_query($con, $nameCheckString) or die("2: Name check query failed...DB issue"); // error code 2 = name already in Db

    if(mysqli_num_rows($nameCheck) > 0)
    {
        echo ("3: Name already exists");
        exit();
    }

    // add user to the table
    $insertuserquery = "INSERT INTO account.people (FirstName,Lastname,Username,Password,Role) VALUES ('".$firstname."','".$lastname."','".$username."','".$password."','".$admin."');";
    mysqli_query($con, $insertuserquery) or die("USER CREATION FAILED");

    echo ($username. " ".$password." " .$firstname);
?>