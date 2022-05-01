<script>
  import TeamsAndPlayers from './TeamsAndPlayers.svelte';
  import ActionButtons from './ActionButtons.svelte';
  export let server;

  // const gameMode = deathmatch => {
  //   let mode = '';
  //   switch (deathmatch) {
  //     case 3:
  //       mode = '1v1';
  //       break;
  //     case 4:
  //       mode = '4v4';
  //       break;
  //     default:
  //       break;
  //   }
  //   return mode;
  // };
</script>

<div>
  <header-image style="background-image: url(https://quakedemos.blob.core.windows.net/maps/thumbnails/{server.map}.jpg), url(https://quakedemos.blob.core.windows.net/maps/thumbnails/_generic.png)">
    <TeamsAndPlayers playersOnServer={server.players} />
  </header-image>
  <body-info>
    <h4>{server.title}</h4>
    <p>{server.description}</p>
    <!-- <p>Ip: {server.address}</p> -->
    <p>Map: {server.map}</p>
    <!-- <p>deathmath: {server.settings.deathmatch} teamplay: {server.settings.teamplay}</p> -->
    <!-- <p>Mode: {gameMode(server.settings.deathmatch, server.settings.teamplay)}</p> -->
    <ActionButtons server={server} />
  </body-info>  
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
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
    min-width: 25%;
    overflow: hidden;
  }
  header-image {
    border-radius: 5px 5px 0 0;
    background-color: black;
    min-height: 20em;
    width: 100%;
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    display: flex;
    align-items: center;
    justify-content: center;
  }
  body-info {
    padding: 1em;
    width: 100%;
    box-sizing: border-box;
  }
</style>
