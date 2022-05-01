<script>
  import {badplaceData} from '../js/stores';

  // eslint-disable-next-line no-undef
  const apiUrl = API_URL;
  // eslint-disable-next-line no-undef
  const connection = new signalR.HubConnectionBuilder()
    .withUrl(apiUrl + '/badplacehub')
    .withAutomaticReconnect()
    // eslint-disable-next-line no-undef
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

  connection.on('Update', message => {
    console.log('Got updated data from Hub!');
    badplaceData.set(JSON.parse(message));
  });

  start();
</script>
