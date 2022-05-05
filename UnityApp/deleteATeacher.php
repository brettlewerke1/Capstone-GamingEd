<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'account');


    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }

    
    $username = $_POST["Username"];

    $queryString = "SELECT * FROM account.people WHERE Username='".$username."';";

    $teacher = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teacher);

    $userId = $userInfo["Id"];

    $queryString = "DELETE FROM account.people WHERE Id='".$userId."';";

    $teacher = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    if($teacher == false)
    {
        echo ("Deletion Error");

        exit();
    }
    else
    {
        echo("Deletion successful!");

    }






?>