$metadata = Invoke-RestMethod -Headers @{"Metadata"="true"} -Method GET -Uri "http://169.254.169.254/metadata/instance?api-version=2020-06-01" | ConvertTo-Json
Write-Host $metadata
