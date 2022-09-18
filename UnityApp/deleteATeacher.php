<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');


    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }

    
    $username = $_POST["Username"];

    $queryString = "SELECT * FROM RTX.Account WHERE Account_Username='".$username."';";

    $teacher = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teacher);

    $userId = $userInfo["Account_ID"];


    // deleting from RTX.Player
    $queryString = "DELETE FROM RTX.Player WHERE Player_AccountID='".$userId."';";

    $teacher = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    if($teacher == false)
    {
        echo ("Deletion Error in Player DB Table");

        exit();
    }
    else
    {
        echo("Deletion successful!");

    }


    
    
    // deleting from RTX.Account
    $queryString = "DELETE FROM RTX.Account WHERE Account_ID='".$userId."';";

    $teacher = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    if($teacher == false)
    {
        echo ("Deletion Error in Account DB Table");

        exit();
    }
    else
    {
        echo("Deletion successful!");

    }

    




?>
