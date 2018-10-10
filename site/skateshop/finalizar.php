<?php
	require_once('includes/config.php');
	include('includes/header.php');

	$idProd = "";

	if(!isset($_POST)) {
		echo "<script>location.href='index.php'</script>";
	}
	else {
		$idProd = $_POST['idProd'];
	}
	
?>
   
<div class="navbar navbar-default yamm" role="navigation" id="navbar">
	<div class="container">
		<div class="navbar-header">
			<a class="navbar-brand home" href="index.php" data-animate-hover="bounce">
				<img src="img/logo.png" alt="Skateshop logo" class="hidden-xs">
				<img src="img/logo-small.png" alt="Skateshop logo" class="visible-xs">
				<span class="sr-only">Skateshop - ir para home</span>
			</a>
			<div class="navbar-buttons">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navigation">
					<span class="sr-only">Toggle navigation</span>
					<i class="fa fa-align-justify"></i>
				</button>
			</div>
		</div>
		<div class="navbar-collapse collapse" id="navigation">
			<ul class="nav navbar-nav navbar-left">
				<li><a href="index.php">Home</a></li>
				<li><a href="produtos.php">Produtos</a></li>
			</ul>
		</div>
	</div>
</div>
<div id="all">
	<div id="content">
		<div class="container">
			<div class="col-md-12" id="checkout">
				<div class="box">
					<h1 class="text-center">Compra efetuada com sucesso!</h1>     
					<?php
						$sql = "UPDATE produtos SET estoque = estoque - 1 WHERE id = ".$idProd;
						if (!mysqli_query($GLOBALS['conn'], $sql)) {
							die('Erro: ' . mysqli_error($conn));
						}
					?>
				</div>
			</div>
		</div>
	</div>
</div>
<?php
	include('includes/footer.php');
?>