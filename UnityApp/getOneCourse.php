<?php
    $con = mysqli_connect('gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com', 'superAdmin', 'ghahyat8', 'RTX');

    
    if(mysqli_connect_error())
    {
        echo ("1: Connection failed"); // error code #1 = connection failed
        exit();
    }

    $classNum = $_POST["ClassNumber"];

    $student = "student";

    $queryString = "SELECT * FROM RTX.Account WHERE CurrentClass='".$classNum."' AND Role='".$student."';";

    $students = mysqli_query($con, $queryString) or die("2:...DB issue"); // error code 2 = name already in Db
    $rows = array();

    while($result =mysqli_fetch_assoc($students))
    {
        $rows[] = $result;

    }

    foreach($rows as $row){
        echo ($row["Firstname"] ."        ".$row["Account_Username"]."        ".$row["CurrentClass"]."/"); 
    }

?>
