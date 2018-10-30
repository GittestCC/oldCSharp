# KintoHub C# Examples

This repository has a basic example of creating an HTTP server with C# that is compatible on KintoHub.

The requirements are as follows:

* Need to use the exact docker file provided in this repository.
* Must listen to port 80 on hostname 0.0.0.0
* Write an apidoc comment for each of your endpoints
* Ensure all your required files are within /app/out

You can run the example with:

docker build -t sample .
docker run sample