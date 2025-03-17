<?php
$serverName = "sql2.7m.pl"; // adres hosta (np sql4.5v.pl)
$serverUser = "sigmamale2454_egzamin-dyplomowy"; // nazwa użytkownika (bazy danych)
$serverPassword = "mojehasloma12znakow"; // hasło użytkownika (bazy danych)
$DBname = "sigmamale2454_egzamin-dyplomowy"; // nazwa bazy danych
$userLogin = $_POST['USERLOGIN']; // login użytkownika uczelni (email)
$userPassword = $_POST['USERPASSWORD']; // haslo użytkownika uczelni

// Validate and sanitize input
$userLogin = trim(htmlspecialchars($userLogin));
$userPassword = trim(htmlspecialchars($userPassword));

if(!$userLogin||!$userPassword){
    echo "400"; //Error 400 - Unauthorized
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