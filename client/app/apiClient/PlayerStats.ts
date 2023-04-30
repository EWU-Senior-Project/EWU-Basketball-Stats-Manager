/* eslint-disable */
/* tslint:disable */
/*
 * ---------------------------------------------------------------
 * ## THIS FILE WAS GENERATED VIA SWAGGER-TYPESCRIPT-API        ##
 * ##                                                           ##
 * ## AUTHOR: acacode                                           ##
 * ## SOURCE: https://github.com/acacode/swagger-typescript-api ##
 * ---------------------------------------------------------------
 */

import { PlayerDto } from './data-contracts';
import { HttpClient, RequestParams } from './http-client';

export class PlayerStats<SecurityDataType = unknown> extends HttpClient<SecurityDataType> {
  /**
   * No description
   *
   * @tags PlayerStats
   * @name GetTopScorersList
   * @summary Retrieves Top scorers
   * @request GET:/PlayerStats/GetTopScorers
   */
  getTopScorersList = (params: RequestParams = {}) =>
    this.request<PlayerDto[], any>({
      path: `/PlayerStats/GetTopScorers`,
      method: 'GET',
      format: 'json',
      ...params,
    });
}
