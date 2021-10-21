
function addPrepareResponse($fileName, $pattern)
{
	
	[System.Collections.ArrayList]$file = Get-Content $fileName
	$insert = @()

	for ($i=0; $i -lt $file.count; $i++) {
  	    if ($file[$i] -match '_result.Body = SafeJsonConvert.DeserializeObject') {
    	    $insert += $i+1 #Record the position of the line after this one
            #write-host "line number:" $i
  		}
	}

	#Now loop the recorded array positions and insert the new text
	$insert | Sort-Object -Descending | ForEach-Object { 
        #write-host $_ 
        $content = $file | Select -Index ($_ - 1) 
        $responseType = $content.Substring($content.IndexOf('<'), $content.IndexOf('>') - $content.IndexOf('<') + 1)

        if ($responseType -eq "ErrorList") {
            $responseType = "object"
        }

        $file.insert($_,"                    await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareResponse$responseType((int)_statusCode, _result.Body, _httpResponse);") 
        }

	Set-Content $FileName $file
}

Export-ModuleMember -Function addPrepareResponse