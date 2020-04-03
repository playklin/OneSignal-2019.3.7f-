<?PHP

require_once 'dbconn.php';// Подключение к БД и пароли храняться в файле dbconn.php

    $id = $_POST["id"];
	$app_id = "18acf8c9-f31d-485a-92ab-8d7b886be084";//$_POST["app_id"];
    $response = sendMessage($app_id);
    $return["allresponses"] = $response;
    $return = json_encode($return);

    $data = json_decode($response, true);
    print_r($data);
    $id = $data['id'];
    print_r($id);

    print("\n\nJSON received:\n");
    print($return);
    print("\n");
    
    function sendMessage($app_id) {
    $content      = array(
        "en" => 'Roman Пушистик '
    );
    
    $headings =  array(
        "en" => 'Roman Проверка '
    );
    /*
    $hashes_array = array();
    array_push($hashes_array, array(
        "id" => "like-button",
        "text" => "Like",
        "icon" => "http://i.imgur.com/N8SN8ZS.png",
        "url" => "https://yoursite.com"
    ));
    array_push($hashes_array, array(
        "id" => "like-button-2",
        "text" => "Like2",
        "icon" => "http://i.imgur.com/N8SN8ZS.png",
        "url" => "https://yoursite.com"
    ));
    */
    $fields = array(
        'app_id' => $app_id,
        'included_segments' => array(
            'All'
        ),
        'data' => array(
            "foo" => "bar"
        ),
        'contents' => $content,
        'headings'=> $headings
        //'web_buttons' => $hashes_array
    );
    
    $fields = json_encode($fields);
    print("\nJSON sent:\n");
    print($fields);
    
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, "https://onesignal.com/api/v1/notifications");
    curl_setopt($ch, CURLOPT_HTTPHEADER, array(
        'Content-Type: application/json; charset=utf-8',
        'Authorization: Basic MzIyMWJiZjMtYjU0ZC00ZDBhLTk1MjktODNmNTY2MzlhYjVj'
    ));
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, TRUE);
    curl_setopt($ch, CURLOPT_HEADER, FALSE);
    curl_setopt($ch, CURLOPT_POST, TRUE);
    curl_setopt($ch, CURLOPT_POSTFIELDS, $fields);
    curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, FALSE);
    
    $response = curl_exec($ch);
    curl_close($ch);
    
    return $response;
}
?>
