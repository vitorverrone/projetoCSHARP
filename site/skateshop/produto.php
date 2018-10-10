<?php
	require_once('includes/config.php');
	include('includes/header.php');

	if(!isset($_GET['prod']) || $_GET['prod'] == "") {
		echo "<script>location.href='index.php'</script>";
	}
	else {
		$idProd = $_GET['prod'];
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
			<div class="col-md-12">
				<?php
					$sql = "SELECT * FROM produtos WHERE id = ".$idProd;
					$result = $GLOBALS['conn']->query($sql);
					if ($result->num_rows > 0) {
						while($row = $result->fetch_assoc()) {
				?>
				<div class="row" id="productMain">
					<div class="col-sm-6">
						<div id="mainImage">
							<?php echo '<img src="data:image/jpeg;base64,'.base64_encode( $row['foto'] ).'" class="img-responsive" />'; ?>
						</div>
					</div>
					<div class="col-sm-6">
						<div class="box">
							<h1 class="text-center"><?php echo $row["nomeProd"];?></h1>
							</p>
							<p class="price">R$ <?php echo $row["preco"];?></p>
							<p class="tamanho text-center">Tamanho: <?php echo $row["tamanho"];?></p>

							<?php

							if($row["estoque"] > 0) {?>
								<p class="text-center buttons">
									<a href="carrinho.php?prod=<?php echo $row["id"];?>" class="btn btn-primary"><i class="fa fa-shopping-cart"></i>Comprar</a>
								</p>
							<?php } else {?>
								<h3 class="text-center">Produto em falta!</h3>
							<?php }?>

						</div>
					</div>
				</div>
				<div class="box" id="details">
					<p>
						<h4>Detalhes do produto</h4>
						<?php echo nl2br(utf8_encode($row["descricao"]));?>
						<hr>
				</div>
				<?php
					}} else {
				?>
					<h2 style="text-align: center;">Produto não encontrado</h2>
				<?php } ?>
			</div>
		</div>
	</div>
</div>
<?php
	include('includes/footer.php');
?>