<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'account');

    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }

    $username = $_POST["Username"];


    $queryString = "SELECT * FROM account.people WHERE Username='".$username."';";

    $teachers = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teachers);
    $returnedFirstname = $userInfo["Firstname"];
    $returnedLastname = $userInfo["Lastname"];
    $returnedUsername = $userInfo["Username"];
    $returnedRole = $userInfo["Role"];
    $returnedClass = $userInfo["CurrentClass"];
    echo($returnedRole." ".$returnedUsername." ".$returnedFirstname." ".$returnedLastname." ".$returnedClass);

?>