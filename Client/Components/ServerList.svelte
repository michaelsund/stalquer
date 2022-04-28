<script>
  import { badplaceData } from "../js/stores";
  import { onDestroy } from "svelte";
  import ServerCard from "./ServerCard.svelte";

  let badplaceDataValue;
  const unsubscribe = badplaceData.subscribe((value) => {
    badplaceDataValue = value;
  });
  onDestroy(unsubscribe);
</script>

<div>
  {#each badplaceDataValue as serverData}
    <ServerCard server={serverData} />
  {/each}
</div>

<style>
  div {
    display: flex;
    flex-direction: row;
    align-items: stretch;
    justify-content: space-around;
    flex-wrap: wrap;
  }
</style>
