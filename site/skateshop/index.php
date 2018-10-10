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
				<li class="active"><a href="index.php">Home</a></li>
				<li><a href="produtos.php">Produtos</a></li>
			</ul>
		</div>
	</div>
</div>

<div id="all">
	<div id="content">
		<div class="container">
			<div class="col-md-12">
				<div id="main-slider">
					<div class="item">
						<img class="img-responsive" src="img/banner1.jpg" alt="" >
					</div>
					<div class="item">
						<img class="img-responsive" src="img/banner2.jpg" alt="">
					</div>
					<div class="item">
						<img class="img-responsive" src="img/banner3.jpg" alt="">
					</div>
				</div>
			</div>
		</div>
		<div id="hot">
			<?php

				$sql = "SELECT * FROM produtos ORDER BY id DESC LIMIT 5";
				$result = $GLOBALS['conn']->query($sql);
				if ($result->num_rows > 0) {
			?>
			<div class="box">
				<div class="container">
					<div class="col-md-12">
						<h2>Últimos produtos adicionados</h2>
					</div>
				</div>
			</div>
			<div class="container">
				<div class="product-slider">
					<?php while($row = $result->fetch_assoc()) {?>
						<div class="item">
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
									<img src="img/product1.jpg" alt="" class="img-responsive">
								</a>
								<div class="text">
									<h3><a href="produto.php?prod=<?php echo $row["id"];?>"><?php echo $row["nomeProd"];?></a></h3>
									<p class="price">R$ <?php echo $row["preco"];?></p>
								</div>
							</div>
						</div>
					<?php } ?>
				</div>
			</div>
			<?php
				}
				$GLOBALS['conn']->close();
			?>
		</div>
	</div>
</div>
<?php
	include('includes/footer.php');
?>