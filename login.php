<?php
$serverName = "localhost"; // adres hosta (np sql4.5v.pl)
$serverUser = "root"; // nazwa użytkownika (bazy danych)
$serverPassword = ""; // hasło użytkownika (bazy danych)
$DBname = "egzamin_dyplomowy"; // nazwa bazy danych
$userLogin = $_POST['USERLOGIN'] ?? ""; // login użytkownika uczelni (email)
$userPassword = $_POST['PASSWORD'] ?? ""; // haslo użytkownika uczelni

// Validate and sanitize input
$userLogin = trim(htmlspecialchars($userLogin));
$userPassword = trim(htmlspecialchars($userPassword));

if($userLogin==""||$userPassword==""){
    echo "401"; //Error 401 - Unauthorized
    exit;
}
$conn = mysqli_connect($serverName,$serverUser,$serverPassword,$DBname);
if(!$conn) die(mysqli_connect_error());
else{
    $result = mysqli_query($conn,"SELECT COUNT(*) FROM osoby WHERE login='$userLogin' AND haslo='$userPassword'");
    if(intval(mysqli_fetch_row($result)[0])==0){
        echo "401"; //Error 401 - Unauthorized
        exit;
    }  //użytkownik nie istnieje (złe hasło bądź login)
    
    echo "200"; //OK
    mysqli_close($conn);
}
?>