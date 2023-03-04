<?php
	$noCli=$_POST['caixa1'];
        $valorFinanciamento=$_POST['caixa2'];
        $totalParcelas=$_POST['caixa3'];
	$txJuros=$_POST['caixa4'];
        
	echo "Nome = {$noCli}<br>";
	echo "Taxa de juros = {$txJuros}<br>";
        echo "Valor do vinanciamento = {$valorFinanciamento}<br>";
?>
