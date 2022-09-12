<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');

    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }


    $username = $_POST["Username"];

    // SQL query
    $queryString = "SELECT * FROM RTX.Account WHERE Account_Username='".$username."';";

    $teachers = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teachers);

    // fetching variables from database
    $returnedFirstname = $userInfo["Firstname"];
    $returnedLastname = $userInfo["Lastname"];
    $returnedUsername = $userInfo["Account_Username"];
    $returnedRole = $userInfo["Role"];
    $returnedClass = $userInfo["CurrentClass"];

    // printing variables receieved from database
    echo($returnedRole." ".$returnedUsername." ".$returnedFirstname." ".$returnedLastname." ".$returnedClass);

?>
