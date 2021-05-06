Import-Module .\generator.psm1
Import-Module .\replace.psm1
Import-Module .\factory.psm1

$templatFile = '.\models\finances-api-model\financesV0.json'
$outputFolder = '.\clients\IL\Finances'
$namespace = 'IL.Library.Amazon.SPAPI.Finances'
$clientname = 'FinancesClient'

generate $templatFile $outputFolder $namespace $clientname

addcode $outputFolder'\'$clientname'.cs' 'HttpClient.SendAsync'  '            PrepareRequest(_httpRequest);'

createfactory '.\factory.template' $outputFolder $clientname'Factory.cs' $namespace $clientname