<?php
	require_once('includes/config.php');
	include('includes/header.php');

	$idProd = "";

	if(isset($_GET['prod']) && $_GET['prod'] != "") {
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
			<div class="col-md-12" id="basket">
				<div class="box">
					<form method="post" action="finalizar.php">
						<h1>Carrinho</h1>
						<?php if($idProd != "") { 
							$sql = "SELECT * FROM produtos WHERE id = ".$idProd;
							$result = $GLOBALS['conn']->query($sql);
							if ($result->num_rows > 0) {
								while($row = $result->fetch_assoc()) {
						?>
							<input type="hidden" name="idProd" value="<?php echo $row["id"];?>">
							<p class="text-muted">Você tem 1 item no seu carrinho</p>
							<div class="table-responsive">
								<table class="table">
									<thead>
										<tr>
											<th colspan="2">Produto</th>
											<th>Quantidade</th>
											<th>Preço unitário</th>
											<th colspan="2">Total</th>
										</tr>
									</thead>
									<tbody>
										<tr>
											<td>
												<a href="#">
													 <?php echo '<img src="data:image/jpeg;base64,'.base64_encode( $row['foto'] ).'" class="img-responsive" />'; ?>
												</a>
											</td>
											<td><a href="#"><?php echo $row["nomeProd"];?></a>
											</td>
											<td>
												<input type="number" readonly value="1" class="form-control">
											</td>
											<td>R$ <?php echo $row["preco"];?></td>
											<td colspan="2">R$ <?php echo $row["preco"];?></td>
										</tr>
									</tbody>
									<tfoot>
										<tr>
											<th colspan="4">Total</th>
											<th colspan="3">R$ <?php echo $row["preco"];?></th>
										</tr>
									</tfoot>
								</table>
							</div>
							<div class="box-footer">
								<div class="pull-right">

									<?php if($row["estoque"] > 0) {?>
										<button type="submit" class="btn btn-primary">
											Finalizar compra <i class="fa fa-chevron-right"></i>
										</button>
									<?php } else { echo "<h3>Produto indisponível</h3>";} ?>
								</div>
							</div>
						<?php }}} else {?> 
							Seu carrinho está vazio!
							<div class="box-footer">
								<div class="pull-left">
									<a href="produtos.php" class="btn btn-default">
										<i class="fa fa-chevron-left"></i> Continuar comprando
									</a>
								</div>
							</div>
						<?php }?>
					</form>
				</div>
			</div>
		</div>
	</div>
</div>
<?php
	include('includes/footer.php');
?>