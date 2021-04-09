Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\orders-api-model\ordersV0.json'
$outputFolder = '.\clients\IL\Orders'
$namespace = 'IL.Library.Amazon.SPAPI.Orders'
$clientname = 'OrdersClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname