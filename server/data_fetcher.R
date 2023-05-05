#!/usr/bin/env Rscript

library(hoopR)


generate_tibbles <- function() {
cat("Getting team box data... \n")
team_box <- load_mbb_team_box(2022)

cat("Getting pbp data... \n")
pbp <- load_mbb_pbp(2022)

cat("Getting player box data... \n")
player_box <- load_mbb_player_box(2022)

cat("Getting schedules... \n")
schedule <- load_mbb_schedule(2022)

return(list(team_box = team_box, pbp = pbp, player_box = player_box, schedule = schedule))
}

tibbles <- generate_tibbles()

output_dir <- "Content"

cat("Checking for output directory... \n")
if (!dir.exists(output_dir)) {
dir.create(output_dir)
}


for (tibble_name in names(tibbles)) {
cat( "Generating", tibble_name, "csv file... \n")
write.table(tibbles[[tibble_name]], file.path(output_dir, paste0(tibble_name, ".csv")), 
sep = ",", row.names = FALSE, col.names = TRUE, quote = FALSE)
}

cat("data fetch SUCCESS \n")