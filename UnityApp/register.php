<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');

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
    $nameCheckString = "SELECT * FROM RTX.Account WHERE Account_Username='".$username."';";


    $nameCheck = mysqli_query($con, $nameCheckString) or die("2: Name check query failed...DB issue"); // error code 2 = name already in Db

    if(mysqli_num_rows($nameCheck) > 0)
    {
        echo ("3: Name already exists");
        exit();
    }

    // add user to the table
    $insertuserquery = "INSERT INTO RTX.Account (Account_Username,Account_Password,Role,Firstname,Lastname) VALUES ('".$username."','".$password."','".$admin."','".$firstname."','".$lastname."');";

    mysqli_query($con, $insertuserquery) or die("USER CREATION FAILED");

    echo ($username. " ".$password." " .$firstname);
?>
