<?php

/**
 * Description of conexaoBanco
 *
 * @author aluno
 */
    $no ="Jonelson da Silva";
    $cid="Lorena";
    $sal="2000";
    
    //put your code here
    try{
        $conecta = new PDO("mysql:host=127.0.0.1;port=3306;dbname=empresas","root","");
        $conecta->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        //Processamento no SQL
        
        $texto="INSERT INTO funcionarios(nome,cidade,salario)VALUE ('".$no."','".$cid."','".$sal."')";
        $conecta->exec($texto);
        
        echo "<h1>Dados cadastrado com sucesso!!! viu?</h1>";
    } 
    catch (PDOException $erro) {
        echo "Não foi realizado a conexão com o banco de dados!!!";
}

