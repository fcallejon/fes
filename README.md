# FEs

FEs tries to be an F# client for Elasticsearch.

Although both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html) and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great to use from C#, using them from F# means doing weird stuff around lambdas and such.

Also by using [Fleece](https://github.com/fsprojects/fleece) to decode/encode JSON gives better control over document going back and forth.

I'm doing this as a weekend-only project, if you are interested in contributing please do. Adding tests would be a great place to help, but [ES Rest API](https://www.elastic.co/guide/en/elasticsearch/reference/7.13/rest-apis.html) it's really big so help there will also be appreciated.
