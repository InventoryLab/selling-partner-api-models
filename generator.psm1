
function generate( $inputFile, 
        $outputFolder, 
        $namespace, 
        $clientName)
{
    autorest --input-file=$inputFile --csharp --output-folder=$outputFolder --namespace=$namespace --override-client-name=$clientName
}

Export-ModuleMember -Function generate