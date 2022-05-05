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

    $nameCheckString = "SELECT * FROM account.people WHERE Username='" . $username . "';";


    $nameCheck = mysqli_query($con, $nameCheckString) or die("2: Name check query failed...DB issue"); // error code 2 = name already in Db

    if(mysqli_num_rows($nameCheck) != 1)
    {
        echo ("5: username not found...");

        exit();
    }

    // get log in info from DB
    $userInfo = mysqli_fetch_assoc($nameCheck);

    $returnedPassword = $userInfo["Password"];
    $returnedUsername = $userInfo["Username"];
    $returnedRole = $userInfo["Role"];
    // check password
    if($password != $returnedPassword)
    {
        echo ("6: incorrect password");
        exit();
    }
    elseif($username != $returnedUsername)
    {
        echo ("6: incorrect username");
        exit(); 
    }
    else
    {
        echo($returnedRole." ".$returnedUsername." ".$returnedPassword);

    }

?>