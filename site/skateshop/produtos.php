<?php
	require_once('includes/config.php');
	include('includes/header.php');
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
				<li class="active"><a href="produtos.php">Produtos</a></li>
			</ul>
		</div>
	</div>
</div>

<div id="all">
	<div id="content">
		<div class="container">
			<div class="col-md-12">
				<div class="box">
					<h1>Produtos</h1>
					<p>Confira nossos produtos</p>
				</div>
				<div class="row products">
					<?php
						$sql = "SELECT * FROM produtos ORDER BY id DESC";
						$result = $GLOBALS['conn']->query($sql);
						if ($result->num_rows > 0) {
							while($row = $result->fetch_assoc()) {
					?>
					<div class="col-md-4 col-sm-6">
						<div class="product">
							<div class="flip-container">
								<div class="flipper">
									<div class="front">
										<a href="produto.php?prod=<?php echo $row["id"];?>">
											<?php echo '<img src="data:image/jpeg;base64,'.base64_encode( $row['foto'] ).'" class="img-responsive" />'; ?>
										</a>
									</div>
									<div class="back">
										<a href="produto.php?prod=<?php echo $row["id"];?>">
											<?php echo '<img src="data:image/jpeg;base64,'.base64_encode( $row['foto'] ).'" class="img-responsive" />'; ?>
										</a>
									</div>
								</div>
							</div>
							<a href="produto.php?prod=<?php echo $row["id"];?>" class="invisible">
								<?php echo '<img src="data:image/jpeg;base64,'.base64_encode( $row['foto'] ).'" class="img-responsive" />'; ?>
							</a>
							<div class="text">
								<h3><a href="produto.php?prod=<?php echo $row["id"];?>"><?php echo $row["nomeProd"];?></a></h3>
								<p class="price">R$ <?php echo $row["preco"];?></p>
								<p class="buttons">
									<a href="produto.php?prod=<?php echo $row["id"];?>" class="btn btn-default">Detalhes</a>
									<a href="carrinho.php?prod=<?php echo $row["id"];?>" class="btn btn-primary">
										<i class="fa fa-shopping-cart"></i>Comprar
									</a>
								</p>
							</div>
						</div>
					</div>
					<?php }}$GLOBALS['conn']->close(); ?>
				</div>
			</div>
		</div>
	</div>
<?php
	include('includes/footer.php');
?>