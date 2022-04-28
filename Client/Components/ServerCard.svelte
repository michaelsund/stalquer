<script>
  export let server;
</script>

<div>
	<h4>{server.title}</h4>
  <p>{server.description}</p>
  <p>Ip: {server.address}</p>
  <p>Map: {server.map}</p>
  <p>Players: {server.players.length}</p>
</div>

<style>
  div {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    flex-wrap: wrap;
    margin: 0 1em 1em 0;
    background-color: white;
    border-radius: 5px;
    padding: 1em;
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    /* min-width: 25vw; */
  }
</style>
