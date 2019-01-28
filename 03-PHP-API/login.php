<?php
header('Content-type: application/json');

$response['validate'] = null;
if ($_POST) {
    // extraer los valores a variables
    $username = $_POST['txtUsuario'];
    $password = $_POST['txtContrasena'];
    // generar la consulta a mysql
    $sql = sprintf("select id,firstname,lastname,email from users where name='%s' and passwd=sha('%s')", $username, $password);
    // crear y abrir la conexion a mysql
    $cnn = new mysqli('127.0.0.1', 'root', 'ttoorr', 'udo', 3306);
    // ejecutar la consulta y obtener resultado
    $rst = $cnn->query($sql);
    // cerrar la conexion a mysql
    $cnn->close();
    // evaluar el resultado
    if ($rst->num_rows) {
        // si encontro al usuario; obtener los datos del usuario
        $u = $rst->fetch_assoc();
        $user['id'] = $u['id'];
        $user['firstname'] = $u['firstname'];
        $user['lastname'] = $u['lastname'];
        $user['email'] = $u['email'];
        // agregar al response
        $response['user'] = $user;
        $response['validate'] = true;
    } else {
        // no encontro al usuario
        $response['validate'] = false;
    }
}
// regresar respuesta
echo json_encode($response, JSON_PRETTY_PRINT);