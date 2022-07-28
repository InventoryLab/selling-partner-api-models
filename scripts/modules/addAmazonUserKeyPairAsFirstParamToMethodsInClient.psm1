
function addAmazonUserKeyPairParam($fileName)
{
	
	[System.Collections.ArrayList]$file = Get-Content $fileName
	$insert = @()

	for ($i=0; $i -lt $file.count; $i++) {
  	if ($file[$i] -match 'WithHttpMessagesAsync(') {
    	$insert += ($i+1) #Record the position of the line before this one
  		}
	}

	#Now loop the recorded array positions and insert the new text
	$insert | Sort-Object -Descending | ForEach-Object { $file.replace($_,'            await IL.Library.Amazon.SPAPI.SharedRuntime.SPAPIInterceptor.PrepareRequest(amazonUserKeyPair, _httpRequest, _configuration, _tokenManagement);') }

	Set-Content $FileName $file
}

Export-ModuleMember -Function addPrepareRequest