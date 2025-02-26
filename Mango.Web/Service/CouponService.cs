﻿using Mango.Web.Models;
using Mango.Web.Models.Dto;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(
            IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/Coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/Coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync<ResponseDto>(new RequestDto
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/Coupon"
            });
        }
    }
}
