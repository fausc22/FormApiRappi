<?php
    //decodificar el JSON
    $json = file_get_contents('php://input');
    $data = json_decode($json, true);
    $tabla = "report_art_06_2023";
    
    $success = true;
    //leer el JSON 
    foreach($data as $row){

        $id_externo = $row['id_externo'];
        $fecha_ticket = $row['fecha_ticket'];
        $nro_ticket = $row['nro_ticket'];
        $cod_barra = $row['cod_barra'];
        $art_desc_vta = $row['art_desc_vta'];
        $depto = $row['depto'];
        $cantidad = $row['cantidad'];
        $precio_unitario = $row['precio_unitario'];
        $total = $row['total'];
        $token_id = $row['token_id'];


        //conexion MYSQL
        $conexion = mysqli_connect("localhost", "root", "251199", "ejemplo_api");
        set_time_limit(300);
        $sql = "INSERT INTO $tabla (id_externo, fecha_ticket, nro_ticket, cod_barra, art_desc_vta, depto, cantidad, precio_unitario, total, token_id) VALUES ('$id_externo', '$fecha_ticket', '$nro_ticket', '$cod_barra', '$art_desc_vta', '$depto', '$cantidad', '$precio_unitario', '$total', '$token_id');";

        //POST
        if(mysqli_query($conexion, $sql)){
            $success = true;
        }else {
            $success = false;
        }
        mysqli_close($conexion);
    }

    

    
    $response = $success ? "Datos cargados con exito!" : "Error: " . $sql . "<br>" . mysqli_error($conn);

    
    echo $response; 
    
    

?>