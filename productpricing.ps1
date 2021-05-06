Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\product-pricing-api-model\productPricingV0.json'
$outputFolder = '.\clients\IL\ProductPricing'
$namespace = 'IL.Library.Amazon.SPAPI.ProductPricing'
$clientname = 'ProductPricingClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname