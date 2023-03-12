$result = $metadata = Invoke-RestMethod -Headers @{"Metadata"="true"} -Method GET -Uri "http://169.254.169.254/metadata/instance?api-version=2020-06-01"
$data = Read-Host -Prompt "Enter the data you wish to search - compute / network "
$key = Read-Host -Prompt "Enter the key you wish to search"

$value = $result.$data.$key

Write-Host "$key is $value"
