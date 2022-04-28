<script>
  import { badplaceData } from '../js/stores';
  const connection = new signalR.HubConnectionBuilder()
    .withUrl("/badplacehub")
    .withAutomaticReconnect()
    .configureLogging(signalR.LogLevel.Information)
    .build();

  async function start() {
    try {
      await connection.start();
    } catch (err) {
      console.log(err);
      setTimeout(start, 5000);
    }
  }

  connection.onclose(async () => {
    await start();
  });

  connection.on("Update", (message) => {
    badplaceData.set(JSON.parse(message));
  });

  start();
</script>
