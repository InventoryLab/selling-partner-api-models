Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\product-fees-api-model\productFeesV0.json'
$outputFolder = '.\clients\IL\ProductFees'
$namespace = 'IL.Library.Amazon.SPAPI.ProductFees'
$clientname = 'ProductFeesClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname