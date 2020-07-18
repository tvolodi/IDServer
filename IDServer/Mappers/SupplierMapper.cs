﻿using IDCommon;
using IDServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer.Mappers
{
    public class SupplierMapper
    {
        public static SupplierDTO SupplierToDTO(Supplier supplier)
        {
            SupplierDTO supplierDTO = new SupplierDTO
            {
                Id = supplier.Id,
                Name = supplier.Name,
                PhoneNo = supplier.PhoneNo,
                IsDeleted = supplier.IsDeleted,
                CreatedDT = supplier.CreatedDT,
                LastUpdatedDT = supplier.LastUpdatedDT,
                DeletedDT = supplier.DeletedDT
            };

            return supplierDTO;
        }

        public static Supplier DTOToSupplier(SupplierDTO supplierDTO)
        {
            Supplier supplier = new Supplier
            {
                Id = supplierDTO.Id,
                Name = supplierDTO.Name,
                PhoneNo = supplierDTO.PhoneNo,
                IsDeleted = supplierDTO.IsDeleted,
                CreatedDT = supplierDTO.CreatedDT,
                LastUpdatedDT = supplierDTO.LastUpdatedDT,
                DeletedDT = supplierDTO.DeletedDT
            };

            return supplier;
        }
    }
}
