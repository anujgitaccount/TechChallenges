# TODO:
We need to write code that will query the meta data of an instance within AWS or Azure or GCP and provide a json formatted output. 
The choice of language and implementation is up to you.

Bonus Points
The code allows for a particular data key to be retrieved individually
Hints
*  Aws Documentation (https://docs.aws.amazon.com/)
*  Azure Documentation (https://docs.microsoft.com/en-us/azure/?product=featured)
*  Google Documentation (https://cloud.google.com/docs)

# About Metadata of an Instance:
The Azure Instance metadata service is a REST endpoint that allows us to get all the information of an Azure instance - OS details, storage, SKUs etc. This is available at the non-routable, static IP address 169.254.169.254 and can be accessed from within a VM only.

# Approach:
For the purpose of the first part of the ask, I created a simple GET call to the uri "http://169.254.169.254/metadata/instance?api-version=2020-06-01 " and because this was a powershell script, it is very simple to parse this output as a json object, simply by pipingthe output to ConvertTo-Json. This allows us to use this in Functions easily.
The script can be run inside any VM and will give all the metadata information of that VM. (GetInstanceMetadata.ps1)
