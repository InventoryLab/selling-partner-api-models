Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\catalog-items-api-model\catalogItems_2020-12-01.json'
$outputFolder = '.\clients\IL\CatalogItems'
$namespace = 'IL.Library.Amazon.SPAPI.CatalogItems'
$clientname = 'CatalogItemsClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname