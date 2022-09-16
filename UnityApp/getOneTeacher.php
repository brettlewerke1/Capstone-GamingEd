<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');

    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }


    $username = $_POST["Username"];

    // SQL query
    $queryString = "SELECT * FROM RTX.Global_View WHERE Account_Username='".$username."';";

    $teachers = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $userInfo = mysqli_fetch_assoc($teachers);

    // fetching variables from database
    $returnedUsername = $userInfo["Account_Username"];
    $className = $userInfo["Course_Tag"];


    // view only selects admins
    $role = "admin";


    // printing variables receieved from database
    echo($role." ".$returnedUsername." ".$className);

?>
